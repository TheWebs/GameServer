using LeagueSandbox.GameServer.Logic.GameObjects.AttackableUnits;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class FogUpdate2 : BasePacket
    {
        public FogUpdate2(Game game, AttackableUnit unit, NetworkIdManager idManager) 
            : base(game, PacketCmd.PKT_S2C_FOG_UPDATE2, 0)
        {
            Write((int)unit.Team);
            Write((byte)0xFE);
            Write((byte)0xFF);
            Write((byte)0xFF);
            Write((byte)0xFF);
            Write(0);
            WriteNetId(unit); // Fog Attached, when unit dies it disappears
            Write(idManager.GetNewNetId()); //Fog NetID
            Write(0);
            Write(unit.X);
            Write(unit.Y);
            Write((float)2500);
            Write(88.4f);
            Write((float)130);
            Write(1.0f);
            Write(0);
            Write((byte)199);
            Write(unit.VisionRadius);
        }
    }
}