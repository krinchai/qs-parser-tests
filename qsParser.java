import java.net.URI;
// import org.apache.http.client.utils.URLEncodedUtils;

/**
 * qsParser
 */
class qsParser {

    public static void main(String[] args) {
        for (String url : new String[]{ 
            "http://foo.bar.com/?hello=jeff&hello=tom&hello=joe",
            "http://foo.bar.com/?hello=jeff,tom,joe",
            "http://foo.bar.com/?hello=jeff&tom&joe" 
        }) {
            System.out.println(url);
            URI uri = URI.create(url);
            System.out.println(uri.getQuery());
        }
    }
    
}