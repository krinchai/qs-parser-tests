package main

import (
	"fmt"
	"net/url"
)

func main() {
	for _, u := range []string{
		"http://foo.bar.com/?hello=jeff&hello=tom&hello=joe",
		"http://foo.bar.com/?hello=jeff,tom,joe",
		"http://foo.bar.com/?hello=jeff&tom&joe",
	} {
		fmt.Println(u)
		uu, _ := url.Parse(u)
		fmt.Println(uu.Query())
	}

}
