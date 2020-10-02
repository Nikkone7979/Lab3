def Selectionsort(array)

  x = array.length - 1
  x.times do |i|
    minimum = i
    for j in (i + 1)..x
      minimum = j if array[j] < array[minimum] end
    array[i], array[minimum] = array[minimum], array[i] if minimum != i end
  array end

ar=[5,6,9,12,1]
Selectionsort(ar)
puts ar