using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Player = Exiled.Events.Handlers.Player;

namespace KillMessages
{
    public class MainClass : Plugin<PluginConfig>
    {
        public override string Name { get; } = "KillMessages";
        public override string Prefix { get; } = "kill_messages";
        public override string Author { get; } = "Jesus-QC";
        public override Version Version { get; } = new (0, 0, 1);

        public override void OnEnabled()
        {
            Player.Died += OnDied;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Died -= OnDied;
            
            base.OnDisabled();
        }

        private void OnDied(DiedEventArgs ev)
        {
            if(ev.Killer is null || ev.Target is null || ev.Target == ev.Killer)
                return;
            
            ev.Killer.ShowHint(Config.Message.Replace("{name}", ev.Target.Nickname), 4);
        }
    }
}