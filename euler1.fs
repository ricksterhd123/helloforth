: sumMultipleThreeOrFive ( limit -- sum )
    0 swap
    1 do
	i 3 mod 0 = i 5 mod 0 = or if
	    i +
	then
    loop
;

1000 sumMultipleThreeOrFive . cr
bye
