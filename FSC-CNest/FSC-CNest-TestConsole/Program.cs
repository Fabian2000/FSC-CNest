using FSC_CNest.IO;

var log = new Logger();
log.Flags = LogMethod.File | LogMethod.Console;
log.Start();
log.Info("Test");
log.Warning("Test");
log.Error("Test");
log.Note("Test");
log.FatalError("Test");
log.Info("Test");