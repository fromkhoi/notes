# change time in DateTime

DateTime s = ...;
TimeSpan ts = new TimeSpan(10, 30, 0);
s = s.Date + ts;