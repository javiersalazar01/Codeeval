package main

import "fmt"
import "log"
import "bufio"
import "os"
import "strconv"

func main() {
    file, err := os.Open(os.Args[1])
    if err != nil {
        log.Fatal(err)
    }   
    defer file.Close()
    scanner := bufio.NewScanner(file)
    for scanner.Scan() {
        
        line := scanner.Text()
    	sum := 0
    	for i := 0; i < len(line); i++ {
    
    		in, err := strconv.Atoi(string(line[i]))
    		if err != nil {
    			fmt.Println(err)
    		}
    		sum = sum + in
    	}
    
    	fmt.Println(sum)
        
        
        
    }   
}