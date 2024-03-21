\ get the largest fibonacci number < limit
\ todo - rewrite to sum only even numbers
: fibonacci ( limit -- n )
    1 2
    BEGIN
	swap over + \ limit 1 2 => limit 2 1 => limit 2 1 2 => limit 2 3
	dup 2over drop > \ limit 2 3 3 => limit 2 3 3 limit 2 => limit 2 3 3 limit
    UNTIL
    nip nip \ snip off the the limit and the 2nd to last fib number
;

1000 fibonacci . cr
bye
