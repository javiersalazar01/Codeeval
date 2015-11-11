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
    
     arrRaw := []string{}
    
    for scanner.Scan() {
      arrRaw = append(arrRaw,scanner.Text())
    }
    
   
	num, arr := arrRaw[0], arrRaw[1:len(arrRaw)]

	aux := ""
	max, posMax := 0, 0

	for i := 0; i < len(arr); i++ {
		max = 0
		for j := i; j < len(arr); j++ {
			if len(arr[j]) > max {
				posMax = j
				max = len(arr[j])
			}
		}

		aux = arr[i]
		arr[i] = arr[posMax]
		arr[posMax] = aux
	}

	number, err := strconv.Atoi(num)
	if err != nil {

	}

	for i := 0; i < number; i++ {
		fmt.Println(arr[i])
	}
    
    
    
}