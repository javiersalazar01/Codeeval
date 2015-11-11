package main

import "fmt"
import "log"
import "bufio"
import "os"
import "strings"

func main() {
    file, err := os.Open(os.Args[1])
    if err != nil {
        log.Fatal(err)
    }   
    defer file.Close()
    scanner := bufio.NewScanner(file)
    for scanner.Scan() {
        line := scanner.Text()
	split := strings.Split(line, " ")
	izq := split[0]
	der := split[1]
	res := ""
	for i := 0; i < len(der); i++ {
		s := string(der[i])
		if s == "1" {
			res = res + strings.ToUpper(string(izq[i]))
		} else {
			res = res + string(izq[i])
		}
	}

	fmt.Println(res)
    }   
}