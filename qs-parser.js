const   url = require('url'),
        querystring = require('querystring');

[
    'http://foo.bar.com/?hello=jeff&hello=tom&hello=joe',
    'http://foo.bar.com/?hello=jeff,tom,joe',
    'http://foo.bar.com/?hello=jeff&tom&joe'
].forEach(function(rawUrl) {
    let parsedUrl = url.parse(rawUrl);
    let qs = querystring.parse(parsedUrl.query);
    console.log(rawUrl);
    console.log(JSON.stringify(qs));
});
