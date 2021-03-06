using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets.PacketDefinitions.S2C
{
    public class HighlightUnit : BasePacket
    {
        public HighlightUnit(Game game, uint netId)
            : base(game, PacketCmd.PKT_S2C_HIGHLIGHT_UNIT)
        {
            // The following structure might be incomplete or wrong
            Write(netId);
        }
    }
}