using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Extensions.Conventions;

namespace learn_ninject_music_player
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var kernel = new StandardKernel())
      {
        kernel.Bind(b => b.FromAssembliesMatching("*")
        .SelectAllClasses()
        .InheritedFrom<ICodec>()
        .BindAllInterfaces());
      }
    }
  }
}
