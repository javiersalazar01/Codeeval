File.open(ARGV[0]).each_line do |line|
    arr = line.split(";");
izq = arr[0];
der = arr[1];
nums = der.split(",");

for i in 0...nums.length do
  for j in (i+1)...nums.length do
    if nums[i].to_i == nums[j].to_i
      puts nums[i]
    end
  end
end
end
