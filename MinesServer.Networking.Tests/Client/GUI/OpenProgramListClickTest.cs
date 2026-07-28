using MinesServer.Networking.Client.Packets.GUI;

namespace MinesServer.Networking.Tests.Client.GUI;

internal class OpenProgramListClickTest : RootClientPacketTest<OpenProgramListClickPacket>
{
    public override OpenProgramListClickPacket Packet => new();
}

