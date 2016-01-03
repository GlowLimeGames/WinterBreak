# Java-projects

Multi-threaded-Request-Scheduler

-This code takes in 2 numbers, n and m, from the command line when running program. N is the size of the circular buffer and M is the int range of 1 to M that the length of time (in seconds) of requests would be.

-We create circular buffer, producer, and consumers. We run the producer and consumers.

-Producer: produce request -> add to circular buffer -> sleep -> produce request...

-Consumers: takes request from circular buffer -> complete request by sleeping the length of request -> takes request from circular buffer...


Anagram-Project
1. Open Anagram.java where we can edit it, for example Sublime.
2. In the String fileName = "___"; we put the input name such as dict1 and dict2.
e.g. if want the output of dict1, the line should be String fileName = "dict1";
3. Compile and run the code.

My algorithm takes in a dictionary file with one line containing one word. Then, when reading in each word, a key/index for each word will be generated. Then, we put the word in the hash table named "hash". Hash is an array that contains two classes: Cell and Element. A Cell is a linked list with Elements in it. An Element is an Object that contains a key of type char[] (different from the integer key generated above) and a linked list. This key is the anagram class with the word alphabetically sorted so that it is unique, for example "banana" would have the ID "aaabnn". 
We first produce an int key so that we can put word into a slot in hash array (a Cell), then go through the Elements in the Cell to see where we can put the word.
If the ID matched with an element already in the hash, we add the new element onto that existing Element because they are in the same anagram class. If we reach the end of the hash, but cannot find any of the same ID, then we create a new Element/anagram class by adding the new element to the back of the Cell. 
Finally, it prints out lines of outcomes, each line representing an anagram class.
Note: There are extra lines with space (no words, just blank space) in the dictionaries. They would become [] in the output.
