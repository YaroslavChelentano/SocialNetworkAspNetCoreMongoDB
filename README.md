# SocialNetworkAspNetCoreMongoDB
QuarantineHub is very actual social network about counteractions to Covid-19
During the quarantine period, communication and a little entertainment are needed more than ever. It was this thought that prompted me to create a social network QuarantineHub. 
![image](https://github.com/YaroslavChelentano/SocialNetworkAspNetCoreMongoDB/blob/master/screenshot.png)
This application is based on MongoDB and C#. I chose this programming language because I believe that it is comfortable and optimal for this task.
In my opinion, the main feature of my project is the large number of games and videos about [coronavirus](https://www.google.com/search?q=coronavirus&hl=uk).
I have done the basic requirements for the program:

 1. add user
 2. add friend
 3. add post
 4. add news feed
 5. add comment
 6. add likes

First, you need to register and enter your email and password. Then you will automatically go to the login window. After logging in, you will see the main window "Home".  There you can publish posts, play games and watch videos. You can add information about yourself by going to the section "Profile". You can find other users and add them as friends in the section "People". To exit, press the buttom "Exit".

<h1>Damp for DB</h1>

<h2>Users</h2>

```
db.user.insert({
	"_id":{"$oid":"5e64f393d6d5b431885711c0"},
	"name":"Ed",
	"nickname":"Sheeran",
	"email":"Sheeran@gmail.com",
	"password":"qwerty",
	"image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"subscribers":[]
})
db.user.insert({
	"_id":{"$oid":"5e64f393d6d5b431885711c1"},
	"name":"Justin",
	"nickname":"Bieber",
	"email":"Bieber@gmail.com",
	"password":"qwerty",
	"image":"https://uploads4.wikiart.org/temp/cf0acabe-15ec-4ee2-8f12-f7c47929a28c.jpg",
	"subscribers":[{"name":"Ed","nickname":"Sheeran","email":"Sheeran@gmail.com",
	"image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU"}]
})
db.user.insert({
	"_id":{"$oid":"5e64f393d6d5b431885711c2"},
	"name":"Josh",
	"nickname":"GJo",
	"email":"gJo@gmail.com",
	"password":"qwerty",
	"image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"subscribers":["name":"Ed","nickname":"Sheeran","email":"Sheeran@gmail.com","image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU"]
})
db.user.insert({
	"_id":{"$oid":"5e64f393d6d5b431885711c3"},
	"name":"Kenny",
	"nickname":"Ken",
	"email":"Ken@gmail.com",
	"password":"qwerty",
	"image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"subscribers":[]
})
db.user.insert({
	"_id":{"$oid":"5e64f393d6d5b431885711c4"},
	"name":"Lira",
	"nickname":"Li",
	"email":"Li@gmail.com",
	"password":"qwerty",
	"image":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg",
	"subscribers":["name":"Ed","nickname":"Sheeran","email":"Sheeran@gmail.com","image":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU"]
})
```
<h2>Posts</h2>

```
db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885711c6"},
	"authorEmail":"gJo@gmail.com",
	"authorName":"Josh",
	"authorNickname":"GJo",
	"time":"2020-02-09T03:43:00.000+08:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"it is rain",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-02-06T03:30:00.000+09:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"wow"}]
})

db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885711c7"},
	"authorEmail":"gJo@gmail.com",
	"authorName":"Josh",
	"authorNickname":"GJo",
	"time":"2020-02-09T03:51:00.000+08:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"i feel bad",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-02-06T03:53:00.000+09:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"not be so sad"}]
})

db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885711c8"},
	"authorEmail":"Li@gmail.com",
	"authorName":"Lira",
	"authorNickname":"Li",
	"time":"2020-03-06T03:45:00.000+06:00",
	"authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg",
	"text":"hello, dear",
	"like":[{"email":"Ken@gmail.com"},{"email":"gJo@gmail.com"}],
	"views":{"$numberInt":"3"},
	"comments":[{"authorEmail":"Ken@gmail.com","authorName":"Kenny","authorNickname":"Ken","authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU","text":"hi","times":"2020-04-06T03:45:00.000+07:00"},
		{"authorEmail":"Ken@gmail.com","authorName":"Kenny","authorSurname":"Ken","authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU","text":"i see your last work, they are magic","time":"2020-04-06T03:46:00.000+07:00"}]
})
db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885711c9"},
	"authorEmail":"Li@gmail.com",
	"authorName":"Lira",
	"authorNickname":"Li",
	"time":"2020-03-06T03:45:00.000+06:00",
	"authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg",
	"text":"im feel better today",
	"like":[{"email":"Ken@gmail.com"},{"email":"gJo@gmail.com"}],
	"views":{"$numberInt":"3"},
	"comments":[{"authorEmail":"Ken@gmail.com","authorName":"Kenny","authorNickname":"Ken","authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU","text":"it is great","times":"2020-04-06T03:45:00.000+07:00"},
		{"authorEmail":"Ken@gmail.com","authorName":"Kenny","authorSurname":"Ken","authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU","text":"i like to heart it","time":"2020-04-06T03:46:00.000+07:00"}]
})
db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885719c0"},
	"authorEmail":"Ken@gmail.com",
	"authorName":"Kenny",
	"authorNickname":"Ken",
	"time":"2020-04-06T03:45:00.000+06:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"today is the best for walking",
	"like":[{"email":"Li@gmail.com"},{"email":"gJo@gmail.com"}],
	"views":{"$numberInt":"2"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-06T03:45:00.000+07:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"i agree"}]
})
db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885718c0"},
	"authorEmail":"Ken@gmail.com",
	"authorName":"Kenny",
	"authorNickname":"Ken",
	"time":"2020-04-06T03:49:00.000+06:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"how are you",
	"like":[{"email":"Li@gmail.com"},{"email":"gJo@gmail.com"}],
	"views":{"$numberInt":"2"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-06T03:50:00.000+07:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"i m fine"}]
})
db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885717c0"},
	"authorEmail":"Sheeran@gmail.com",
	"authorName":"Ed",
	"authorNickname":"Sheeran",
	"time":"2020-04-06T03:49:00.000+08:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"i complete my work",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-06T03:50:00.000+08:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"wooow"}]
})

db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885716c0"},
	"authorEmail":"Sheeran@gmail.com",
	"authorName":"Ed",
	"authorNickname":"Sheeran",
	"time":"2020-04-08T03:49:00.000+08:00",
	"authorimage":"https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
	"text":"i have cat",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-08T03:49:00.000+09:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"congratulations"}]
})

db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885715c0"},
	"authorEmail":"Bieber@gmail.com",
	"authorName":"Justin",
	"authorNickname":"Bieber",
	"time":"2020-04-06T03:49:00.000+09:00",
	"authorimage":"https://uploads4.wikiart.org/temp/cf0acabe-15ec-4ee2-8f12-f7c47929a28c.jpg",
	"text":"hello all",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-06T03:50:00.000+09:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"hello"}]
})


db.post.insert({
	"_id":{"$oid":"5e64f3b8d6d5b431885751c0"},
	"authorEmail":"Bieber@gmail.com",
	"authorName":"Justin",
	"authorNickname":"Bieber",
	"time":"2020-04-09T03:43:00.000+09:00",
	"authorimage":"https://uploads4.wikiart.org/temp/cf0acabe-15ec-4ee2-8f12-f7c47929a28c.jpg",
	"text":"i need new friend",
	"like":[],
	"views":{"$numberInt":"0"},
	"comments":[{"_id":{"$oid":"5e64f3b8d6d5b431885711c5"},"authorEmail":"Li@gmail.com","authorName":"Lira","authorNickname":"Li","time":"2020-04-06T03:50:00.000+09:00","authorimage":"https://uploads4.wikiart.org/images/gustav-klimt.jpg!Portrait.jpg","text":"i can be your friend"}]
})
```
<h1>Neo4j Graph</h1>

![image](https://github.com/YaroslavChelentano/SocialNetworkAspNetCoreMongoDB/blob/master/graphScreen.png)
