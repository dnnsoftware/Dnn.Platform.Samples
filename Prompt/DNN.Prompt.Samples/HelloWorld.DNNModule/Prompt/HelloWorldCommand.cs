using Dnn.PersonaBar.Library.Prompt;
using Dnn.PersonaBar.Library.Prompt.Attributes;
using Dnn.PersonaBar.Library.Prompt.Models;

namespace HelloWorld.DnnModuleHelloWorld.DNNModule.Prompt
{
    [ConsoleCommand("hello-world2", "HelloWorldCategory", "Prompt_HelloWorldCommand_Description")]
    public class HelloWorldCommand : ConsoleCommandBase
    {
        [FlagParameter("name", "Prompt_HelloWorldCommand_FlagPersonName", "String", true)]
        private const string FlagPersonName = "name";
        private string PersonName { get; set; }
        public override void Init(string[] args, DotNetNuke.Entities.Portals.PortalSettings portalSettings,
            DotNetNuke.Entities.Users.UserInfo userInfo, int activeTabId)
        {
            base.Init(args, portalSettings, userInfo, activeTabId);
            PersonName = GetFlagValue(FlagPersonName, "FlagPersonName", "", true, true);
        }

        public override ConsoleResultModel Run()
        {
            return new ConsoleResultModel($"Welcome {PersonName}");
        }

        public override string LocalResourceFile => "~/DesktopModules/HelloWorld.DNNModule/App_LocalResources/HelloWorld.resx";
    }
}
