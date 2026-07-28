using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MinesServer.Networking.Client.Packets.GUI;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public readonly record struct OpenProgramListClickPacket() : IRootClientPacket<OpenProgramListClickPacket>
{
    public byte PacketCode => RootClientPacketCodeProvider.Cache<OpenProgramListClickPacket>.Code;

    public int Size => Unsafe.SizeOf<OpenProgramListClickPacket>();

    public int Encode(Span<byte> output) => output.UnsafeWrite(this);

    public static OpenProgramListClickPacket Decode(ReadOnlySpan<byte> input) => input.UnsafeRead<OpenProgramListClickPacket>();
}
