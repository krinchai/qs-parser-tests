# qs-parser

Nodejs and go behave as expected by default. Dotnetcore, official library from MS returns the same result as previous 2. Python and java seem to return the raw query string.

```bash
$ node qs-parser.js
    http://foo.bar.com/?hello=jeff&hello=tom&hello=joe
    {"hello":["jeff","tom","joe"]}
    http://foo.bar.com/?hello=jeff,tom,joe
    {"hello":"jeff,tom,joe"}
    http://foo.bar.com/?hello=jeff&tom&joe
    {"hello":"jeff","tom":"","joe":""}

$ py qs-parser.py
    http://foo.bar.com/?hello=jeff&hello=tom&hello=joe
    hello=jeff&hello=tom&hello=joe
    http://foo.bar.com/?hello=jeff,tom,joe
    hello=jeff,tom,joe
    http://foo.bar.com/?hello=jeff&tom&joe
    hello=jeff&tom&joe

$ dotnet run
    http://foo.bar.com/?hello=jeff&hello=tom&hello=joe
    ?hello=jeff&hello=tom&hello=joe
    [hello, jeff,tom,joe]
    http://foo.bar.com/?hello=jeff,tom,joe
    ?hello=jeff,tom,joe
    [hello, jeff,tom,joe]
    http://foo.bar.com/?hello=jeff&tom&joe
    ?hello=jeff&tom&joe
    [hello, jeff]
    [tom, ]
    [joe, ]

$ javac qsParser.java && java qsParser
    http://foo.bar.com/?hello=jeff&hello=tom&hello=joe
    hello=jeff&hello=tom&hello=joe
    http://foo.bar.com/?hello=jeff,tom,joe
    hello=jeff,tom,joe
    http://foo.bar.com/?hello=jeff&tom&joe
    hello=jeff&tom&joe

$ go run qs-parser.go
    http://foo.bar.com/?hello=jeff&hello=tom&hello=joe
    map[hello:[jeff tom joe]]
    http://foo.bar.com/?hello=jeff,tom,joe
    map[hello:[jeff,tom,joe]]
    http://foo.bar.com/?hello=jeff&tom&joe
    map[hello:[jeff] joe:[] tom:[]]
```