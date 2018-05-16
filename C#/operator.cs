int? c = null;

// d = c, unless c is null, in which case d = -1. (gán d bằng-1 nếu c null, ngược lại d bằng c)
int d = c ?? -1;