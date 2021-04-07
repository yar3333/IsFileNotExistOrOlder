using System;
using System.IO;

namespace IsFileNotExistOrOlder
{
    static class Program
    {
        static int Main(string[] args)
	    {
			if (args.Length != 2 || !File.Exists(args[1]))
            {
                Console.WriteLine("Using: IsFileNotExistOrOlder <path_to_dest_file> <path_to_src_file>");
				Console.WriteLine("Exit code is 2 if <path_to_dest_file> is not exist or older than <path_to_src_file>. Otherwise exit code is 1.");
                return 0;
            }


            return !File.Exists(args[0]) || File.GetLastWriteTimeUtc(args[0]) < File.GetLastWriteTimeUtc(args[1]) ? 2 : 1;
        }
    }
}
