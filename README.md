# .net painter with wcf protocol

the painter project has 3 parts:,
the painter ui, the painter service and the wcf contract between them
![alt text](https://github.com/sharon-hadar-leverate/.net-C-painter-with-wcf-protocol/blob/master/assets/simple1.PNG)

the painter ui is a winform that you can draw rectangles, cyrcles, line, brush and pencile with a color that you can pick.

the painter server alows you to save and open system "drawing" files.

all system drawing are saved to SQL database which needs to be configure at the WCFPainter class at:
```
  using (var conn = new SqlConnection("Server=.;Integrated Security=true; MultipleActiveResultSets = True"))
```
