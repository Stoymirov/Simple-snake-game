using MilitaryElite;
using MilitaryElite.IO.Models;

IEngine engine = new Engine(new FileWriter("../../../result.txt"), new FileReader("../../../myFile.txt"));

engine.Run();