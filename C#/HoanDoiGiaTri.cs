int x = 1;
int y = 2;

x = x ^ y;
y = x ^ y;
x = x ^ y;

/// Ghi chú: toán tử XOR trong C# được quy định là ký tự '^'
				// x: 2
				// y: 1