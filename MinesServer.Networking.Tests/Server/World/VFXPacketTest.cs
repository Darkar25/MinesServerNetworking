using MinesServer.Networking.Server.Packets.World;

namespace MinesServer.Networking.Tests.Server.World;

internal class VFXPacketTest : PacketTest<VFXPacket>
{
    public override VFXPacket Packet => new(
        Data.VFX.C190,
        572,
        19,
        57,
        [
            new("clr", "F00"),
            new("radius", "15")
        ]);
}