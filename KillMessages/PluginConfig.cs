using Exiled.API.Interfaces;

namespace KillMessages
{
    public class PluginConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string Message { get; set; } = "Killed <color=red>{name}</color>";
    }
}