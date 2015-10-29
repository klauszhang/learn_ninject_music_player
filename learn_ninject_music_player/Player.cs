using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_ninject_music_player
{
  public class Player
  {
    private readonly ICodec[] codecs;
    public Player(IEnumerable<ICodec> codecs)
    {
      this.codecs = codecs.ToArray();
    }

    public void Play(FileInfo fileInfo)
    {
      ICodec supportingCodec = FindCodec(fileInfo.Extension);
      using(var rawStream = fileInfo.OpenRead())
      {
        var decodedStream = supportingCodec.Decode(rawStream);
        PlayStream(decodedStream);
      }
    }

    private void PlayStream(Stream decodedStream)
    {
      // to be done
      throw new NotImplementedException();
    }

    private ICodec FindCodec(string extension)
    {
      foreach (ICodec codec in codecs)
        if (codec.CanDecode(extension))
          return codec;

      throw new Exception("File type not supported.");
    }
  }
}
