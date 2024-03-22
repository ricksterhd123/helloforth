\ get the largest fibonacci number < limit
\ NOTE: this gets fibonacci number N+1 where Nth digit <= limit
\ todo - rewrite to sum only even numbers
: fibonacci ( limit -- n )
    0 1
    BEGIN
	swap over + \ limit 0 1 => limit 1 0 => limit 1 0 1 => limit 1 1
	dup 2over drop > \ limit 1 1 => limit 1 1 1 limit 1 => limit 1 1 1 limit
    UNTIL
    nip nip \ snip off the the limit and the 2nd to last fib number
;


\ get the sum of fibonacci terms which are even
: evenFibonacci ( limit -- nsum )
    0 0 1 \ this is our nsum n1 n2
    BEGIN
	\ replace n1->n2 and n2->n3
	swap over
	+

	\ check if n3 is even
	\ nsum := nsum + n3
	dup 2 mod 0 =
	IF
	    rot over
	    + -rot
	THEN

	\ fetch limit from the bottom of the stack
	\ compare with n3
	2over drop over
	<
    UNTIL
    drop drop nip
;

10 fibonacci . cr
4000000 evenFibonacci . cr
bye
