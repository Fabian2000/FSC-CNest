using FSC_CNest.IO;

var pb = new PathBuilder();
pb.GoTo(@"C:\test");
pb.GoBack();
pb.GoTo("folder");
pb.GoForward();
pb.GoTo("otherFolder/moreFolder");

Console.WriteLine(pb);