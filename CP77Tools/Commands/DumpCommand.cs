﻿using System.CommandLine;
using System.CommandLine.Invocation;
using CP77Tools.Tasks;

namespace CP77Tools.Commands
{
    public class DumpCommand : Command
    {
        private new const string Name = "dump";
        private new const string Description = "Target an archive or a directory to dump archive information.";
        
        public DumpCommand() : base(Name, Description)
        {
            AddOption(new Option<string[]>(new[] {"--path", "-p"}, "Input path to .archive or to a directory (runs over all archives in directory)."));
            AddOption(new Option<bool>(new[] {"--imports", "-i"}, "Dump all imports (all filenames that are referenced by all files in the archive)."));
            AddOption(new Option<bool>(new[] {"--missinghashes", "-m"}, "List all missing hashes of all input archives."));
            AddOption(new Option<bool>(new[] {"--texinfo"}, "Dump all xbm info."));
            AddOption(new Option<bool>(new[] {"--classinfo"}, "Dump all class info."));
            AddOption(new Option<bool>(new[] {"--dump", "-d"}, "Dump archive information."));
            AddOption(new Option<bool>(new[] {"--list", "-l"}, "List contents of archive."));

            
            Handler = CommandHandler.Create<string[], bool, bool, bool, bool, bool, bool>(ConsoleFunctions.DumpTask);
        }
    }
}