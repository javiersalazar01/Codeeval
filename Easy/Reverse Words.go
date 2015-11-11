
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

    	splited := strings.Split(line, " ")
    	res := ""
    	for i := len(splited) - 1; i >= 0; i-- {
    		res = res + splited[i] + " "
    	}
    	res = strings.Trim(res, " ")
    	fmt.Println(res)
        
    }   
}