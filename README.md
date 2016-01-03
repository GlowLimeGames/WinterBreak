# Java-projects

Multi-threaded-Request-Scheduler

-This code takes in 2 numbers, n and m, from the command line when running program. N is the size of the circular buffer and M is the int range of 1 to M that the length of time (in seconds) of requests would be.

-We create circular buffer, producer, and consumers. We run the producer and consumers.

-Producer: produce request -> add to circular buffer -> sleep -> produce request...

-Consumers: takes request from circular buffer -> complete request by sleeping the length of request -> takes request from circular buffer...
