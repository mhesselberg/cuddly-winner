namespace GithubNugetWorkflowPoc;

public class LibraryTest
{
    private string? HelloWorldString { get; set; }
    public string GetHelloWorldString()
    {
        // test that a new tag was added
        return HelloWorldString ?? "Hello world";
    }
    
    public void SetHelloWorldString(string helloWorldString)
    {
        // test that a new tag was added
        HelloWorldString = helloWorldString;
    }
    
    // test patch
    
    // used to trigger new minor
}