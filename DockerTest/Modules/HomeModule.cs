using Nancy;

namespace DockerTest.Modules{
    public class HomeModule: NancyModule
    {
        public HomeModule(){
            Get("/", args => "Hello from Nancy on .NET Core!");
            Get("/person/{name}", args => new Person(){ Name = args.name});
        }
    }

    public class Person{
        public string Name { get; set; }
    }
}