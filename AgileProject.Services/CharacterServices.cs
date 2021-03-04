using AgileProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileProject.Services
{
    public class CharacterServices
    {
        private readonly Guid _userId;

        public CharacterService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCharacter(CharacterCreate model)
        {
            var entity =
                new Character()
                {
                    UserId = _userId,
                    Name = model.Name,
                    Class = model.Class,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Characters.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CharacterListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Characters
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new CharacterListItem
                                {
                                    Id = e.Id,
                                    Name = e.Name,
                                    Class = e.Class
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
