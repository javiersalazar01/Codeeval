package main

import "fmt"
import "log"
import "bufio"
import "os"


func main() {
    file, err := os.Open(os.Args[1])
    if err != nil {
        log.Fatal(err)
    }   
    defer file.Close()
    scanner := bufio.NewScanner(file)
    for scanner.Scan() {
       
       line := scanner.Text()
	res := ""
	for i := 0; i < len(line); i++ {
		s := string(line[i])

		switch {
		case s == "a":
			res = res + "0"

		case s == "b":
			res = res + "1"

		case s == "c":
			res = res + "2"

		case s == "d":
			res = res + "3"

		case s == "e":
			res = res + "4"

		case s == "f":
			res = res + "5"

		case s == "g":
			res = res + "6"

		case s == "h":
			res = res + "7"

		case s == "i":
			res = res + "8"

		case s == "j":
			res = res + "9"

		case s == "0" || s == "1" || s == "2" || s == "3" ||
			s == "4" || s == "5" || s == "6" || s == "7" ||
			s == "8" || s == "9":
			res = res + s

		}

	}
	
	if len(res) == 0 {
		fmt.Println("NONE")
	} else {

		fmt.Println(res)
	}
	
    }   
}