namespace Creational_Factory_Project
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class Resume : Document
    {
        // Factory Method implementation

        public override void CreatePages()
        {
            Pages.Add(new DotNetPosition());
            Pages.Add(new JavaScriptPosition());
        }
    }
}
