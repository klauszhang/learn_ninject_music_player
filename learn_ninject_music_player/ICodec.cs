using System.IO;

namespace learn_ninject_music_player
{
  public interface ICodec
  {
    string Name { get; }
    bool CanDecode(string extension);
    Stream Decode(Stream inStream);
  }
}
