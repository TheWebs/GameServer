using LeagueSandbox.GameServer.Logic.GameObjects.Missiles;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class ShowProjectile : BasePacket
    {
        public ShowProjectile(Game game, Projectile p)
            : base(game, PacketCmd.PKT_S2C_SHOW_PROJECTILE, p.Owner.NetId)
        {
            WriteNetId(p);
        }
    }
}