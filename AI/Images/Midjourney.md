For midjourney, I recommend you create a private server and invite the bot. This way they are private and you are not bothered by others works and massive queues. Prompt engineering is a long topic, but I would mention a few parameters you add to the end to massively improve the quality. ex: 
```
/imagine image url <prompt> --ar 3:2 --v 5 --q 2 --s 250
```
* **ar** is aspect ratio, by default AI's are trained to produce 512 px square images. There are other AI's that extend them to a specific direction aspect ration 3:2 will set that output will not be a square but widescreen result
* **v** is the version, version 5 is the latest and produces by far the highest quality images.
* **q** is literally quality, you can set value between 0 and 1 ex 0.25, 2 and 5. Higher value return better results, but takes more computational power, and depending on your premium plan even I don't run everything on 5.
* **s** is for steps. With each step uses AI to dediffuse image and add detail, with some algorithms 50 is fine and it does not improve after that for others it depends. 250 seems like an overkill, but I happen to use it.

There is an option to upscale inside the app, but people also use external tools to do that. Basically doing so will increase ex: 512 px image to 4k.

For example:
```
Unraveling the ambassador program to find new great employees, magic in the air --ar 3:2 --v 5 --q 5 --s 250
```
![Unraveling the ambassador program to find new great employees, magic in the air --ar 3:2 --v 5 --q 5 --s 250](https://media.discordapp.net/attachments/313326716879896577/1089852917571395664/margusmartsepp_Unraveling_the_ambassador_program_to_find_new_gr_8592871b-3de2-4fcb-9140-816fe44cb5ff.png?width=1014&height=676)