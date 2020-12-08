# BirdsWarC#
the app is Birds living in a forest have their own rectangular area around their nest for feeding and mating. 
Such an area is called a territory. If territories of two birds intersect, the birds may start a fight.
The data of the birds are stored in the file birds.in. In its first line there is the number of birds N and the dimensions of the forest. 
The next N lines are the positions of nests and the radii of territories separated by semicolons. 
For example, if bird i has its nest at (xi, yi) and its territory has radius r then the top-left corner of its territory is at (xi – r, yi – r)
while the bottom-right corner is at (xi + r, yi + r). 
Positions that are out of the forest can be ignored.
the result should answer three qustion:
1-which birds have non-intersecting territories?
2-what is the most dangerous place where the maximal number of territories intersect?
3-places that do not belong to any bird?
the result should be stored into a new file Birds.Out.
