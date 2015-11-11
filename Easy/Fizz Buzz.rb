File.open(ARGV[0]).each_line do |line|
    
    arr = line.split(' ')
    x = arr[0].to_i
    y = arr[1].to_i
    z = arr[2].to_i
    res = ""
    
    1.upto(z) { |i| 
      modX = i % x
      modY = i % y
      if modX == 0 and modY == 0
        res << "FB "
      elsif modX == 0
        res << "F "
      elsif modY == 0  
        res << "B "
      else
        res << "#{i} "
      end
    }
    
    puts res.strip
end
