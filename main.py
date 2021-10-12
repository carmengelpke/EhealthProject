import pandas as pd
import play_scraper
from tinydb import TinyDB, Query
import ssl
import random
import itertools
from random import choice
from itertools import permutations

db= TinyDB('./lab04DB.json') #create the json file
dbtxt= TinyDB('./lab04DB.txt') #create the txt file PROVVISORIO!

from google_play_scraper import app

#df = pd.read_csv(r'C:/Users/maryb/Desktop/playstore.csv') now the kaggle DB is not useful
#a = ['kids', 'kid', 'children', 'child', 'youth', 'preschool', 'toddler']
#b = ['learning', 'learn', 'education', 'educational', 'serious', 'cognitive', 'skills', 'development', 'applied']
#c = ['game', 'games', 'app']
#a,b, and c now are not used, but maybe its more elegant to use them when defining keywords
u=0 #only to count the right number of combinations
#samples = random.sample(itertools.product(a, b, c), 7)

keywords = [['kids', 'kid', 'children','child', 'youth', 'preschool', 'toddler'],['learning', 'learn', 'education', 'educational' ,'serious', 'cognitive', 'skills', 'development', 'applied'],['game', 'games', 'app']]
z=list(itertools.product(*keywords)) #take a world from every group

print(len(z)) #numbera*numberb*numberc=7*9*3
for i in range(len (z)):
    listquery=list(permutations(z[i]))   #create permutations where orders matter
    for j in range(6):
        querysep=listquery[j]      #in this way every time the variable query has the value of the current permutation
        query= " ".join(querysep) #to eliminate' and ,
        print(query)      #print just to see all the possible queries
        u=u+1             #just to count every query=189*6
        output = play_scraper.search(query, page=12)
        for app in output:   #RIMETTILO SE NON FUNZIONA DENTRO IL FOR
            dbtxt.insert(app)
    #permutazioni = list(permutations([4, 5, 2]))
    #print(query)
#e=len(z)
#print(e)
#print(z[0]) i can select a single pattern from a list

print(u) #to count the righ number of combinations
#for i in range(10):
    #combination = (choice(a), choice(b), choice(c))
   # print(combination)


ssl._create_default_https_context = ssl._create_unverified_context
db= TinyDB('./lab04DB.json')
dbtxt= TinyDB('./lab04DB.txt')

#output=play_scraper.search(query,page=12) #RIMETTILO SE NON FUNZIONA DENTRO IL FOR
#for app in output: QUESTO SERVE PER IL FILE JSON MA SICCOME NON RIESCO AD APRIRLO PROVO PRIMA CON IL TXT MA QUESTO E IL DEF CHE VA NEL CICLO FOR!
   # db.insert(app)
#print(output)

#for app in output:   #RIMETTILO SE NON FUNZIONA DENTRO IL FOR
   # dbtxt.insert(app)