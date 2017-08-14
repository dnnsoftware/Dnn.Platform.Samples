using Dnn.PersonaBar.Library.Prompt;
using Dnn.PersonaBar.Library.Prompt.Attributes;
using Dnn.PersonaBar.Library.Prompt.Models;

namespace HelloWorld.Library
{
    [ConsoleCommand("hello-world1", "Hello World", "This is a demo command for prompt")]
    public class HelloWorldCommand : ConsoleCommandBase
    {
        [FlagParameter("name", "Name of the Person", "String")]
        private const string FlagPersonName = "name";
        private string PersonName { get; set; }
        public override void Init(string[] args, DotNetNuke.Entities.Portals.PortalSettings portalSettings,
            DotNetNuke.Entities.Users.UserInfo userInfo, int activeTabId)
        {
            base.Init(args, portalSettings, userInfo, activeTabId);
            PersonName = GetFlagValue(FlagPersonName, "Person Name", "Guest", false, true);
        }

        public override string ResultHtml => "Hello World Html Result";

        public override ConsoleResultModel Run()
        {
            return new ConsoleResultModel($"Welcome {PersonName}");
        }

        public override string LocalResourceFile => string.Empty;
    }
}
