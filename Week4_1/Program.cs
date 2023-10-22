using Week4_1.Persistance;
using Week4_1.Entities;

Console.WriteLine("Entity FrameWork Core _ InMemory");

NoteMasterDbContext _context = new();

_context.Notes.Add(new("Note 1"));
_context.Notes.Add(new("Note 2"));
_context.Notes.Add(new("Note 3"));

_context.SaveChanges();

List<Note> notes = _context.Notes.ToList();

Console.WriteLine();
