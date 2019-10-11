from urllib.parse import urlparse

for rawUrl in [
    'http://foo.bar.com/?hello=jeff&hello=tom&hello=joe',
    'http://foo.bar.com/?hello=jeff,tom,joe',
    'http://foo.bar.com/?hello=jeff&tom&joe'
]: 
    print(rawUrl)
    o = urlparse(rawUrl)
    print(o.query)