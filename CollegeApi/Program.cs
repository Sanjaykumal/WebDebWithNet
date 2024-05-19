var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CollegeDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Learning developing REST API on .NET");
app.MapGet("/Courses", (CollegeDbContext db) => db.Courses.ToList());
app.MapGet("/Courses/{id:int}", (int id, CollegeDbContext db) => db.Courses.Find(id));
app.MapGet("/Sessions", (CollegeDbContext db) => db.Sessions.ToList());
app.MapGet("/Sessions/{id:int}", (int id, CollegeDbContext db) => db.Sessions.Find(id));
app.Run();
