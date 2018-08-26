# C#.Net String Matching Algorithms 
Welcome to the MatchingAlgos wiki!


# Matching Algorithms Types


![](https://lh3.googleusercontent.com/edKj7ULsyanf2B3BUGCSrGl6aQKsUqchiLlA9YIqXh0wNg_dfy7K_CP-0-d0t3ndLnQN-4RsmpCJ1RVL3HidFfSA_NOKjWJfNkQjDap_UBI_lHKdSNqFFjvx3A5auXZDHFiHRJfK=w640)


# Deterministic Matching
An exact match on a data attribute. For example, if two records share the same social security number they refer to the same patient


![](https://lh3.googleusercontent.com/LpoIGOW59D_EGhiwKfVoxI2QLOxblKdPqI9aeUc7DQDOzfZURDAr9RZCzi7QQNWeHF3DUE8RF0HiwePmym-hvagemvynwzYE0iCGMVrWhyEHavXQhMfNoVmahfnZP8z4zNMKOA1i=w200)


# Probabilistic Matching

A statistical approach that evaluates the probability that two records represent the same person
By assigning a score to each data element and adding scores to produce a final score, matches can be made with a degree of confidence if a predetermined threshold is met
!<br />
![](https://lh3.googleusercontent.com/SLsfUoB3uKvPeI-lOIg2Bk5TG3wlKSHnIb09wNvt0qHcBMGkKYPAguVzDnHYeX90mSy550csIu-WJMZsasGT4XbQroGiSBzyAJQeKTYtLLaTxD-HDrdGSK1mEyIkPy2jypL7gHLz=w300)


# Types of Probabilistic Matching  Algorithms 
![](https://lh3.googleusercontent.com/MTiYp74eQZ0mY0W_Y3t4kX-m1XR8Io-RVuPseWNQArxIsjhcF5R1ircY7-xwdP3uEANzN8BL1a1V_6QNd563sDxpqxrwO8OB4lIM2_WIrJVz363FmcvsQfZmdgfoN3WRMkQz3j6A=w2400)

# Cosine similarity
![](https://lh3.googleusercontent.com/pq8ipies7fJscAvrvICknEJWjnSoaJkxlNgs6XRFP09bQ9vQ6FMS1Onx-4VP2qfN_n7pWrxlX_-ikR-NWv93Rz6UX7_GIqaLmnIgHpO9cNDoy2qEmEUBNLKdMT52aT_6Ii-XUIU4=w600)

![](https://lh3.googleusercontent.com/xlyssrsbIO8_RTQ_PYpbd3nihssnDbdp3dHlxccfuc5YKUGDvzbXSYG4YFwh78u9SJAVPjcp0AsJTQN_EOg20WFmmj1fHjVvv3sl7XvGtqvWLEjJ_MgfCK7WVjG8hTLyYoAhJoRH=w2400)


Here are two very short texts to compare:
1.	Julie loves me more than Linda loves me
2.	Jane likes me more than Julie loves me
We want to know how similar these texts are, purely in terms of word counts (and ignoring word order). We begin by making a list of the words from both texts:
me Julie loves Linda than more likes Jane
Now we count the number of times each of these words appears in each text:
   me   2   2
 Jane   0   1
Julie   1   1
Linda   1   0
likes   0   1
loves   2   1
 more   1   1
 than   1   1
We are not interested in the words themselves though. We are interested only in those two vertical vectors of counts. For instance, there are two instances of 'me' in each text. We are going to decide how close these two texts are to each other by calculating one function of those two vectors, namely the cosine of the angle between them.
The two vectors are, again:
a: [2, 0, 1, 1, 0, 2, 1, 1]

b: [2, 1, 1, 0, 1, 1, 1, 1]
The cosine of the angle between them is about 0.822.
These vectors are 8-dimensional. A virtue of using cosine similarity is clearly that it converts a question that is beyond human ability to visualise to one that can be. In this case you can think of this as the angle of about 35 degrees which is some 'distance' from zero or perfect agreement.
