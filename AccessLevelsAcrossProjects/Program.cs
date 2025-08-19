namespace AccessLevelsAcrossProjects;

class Program
{
    static void Main(string[] args)
    {
       AccessLevelsAcrossProjects.Core.HelperExample.DoSomething();
       HelperExample.DoSomething();
    }
}

/*
 * Access Levels Across Projects
 
Goal: understand internal.

Two projects: Core (class library) and App (console).

In Core, create an internal helper; try to use it from App.

Accept: compile error when accessing internal type from App (document error).
 */