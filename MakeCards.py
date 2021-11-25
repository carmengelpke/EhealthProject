##IMPORTS 
import cv2 as cv #library to work with images


##Path to image
pathImg = "D:/Documents/Cours3A/eHealthProject_test/card.jpg"

##Opening txt file with the words
myfile = open("words.txt", "rt") # open file
contents = myfile.readlines()    # read the entire file to string

Lwords =[] #list that will contain the words 
for word in contents: 
    if word.endswith('\n'):#if the words end with '\n', remove it
         word = word.strip() #remove \n
    Lwords.append(word) #make the list
myfile.close()

##Add text 
for i in range(len(Lwords)):
    im = cv.imread(pathImg) #load image
    cv.putText(im, text=Lwords[i], org=(150,250),
                fontFace= cv.FONT_HERSHEY_SIMPLEX, fontScale=1, color=(0,0,0),
                thickness=2, lineType=cv.LINE_AA) #add the text to the image
    cv.imwrite("Cards/image"+ str(i)+".png",im) #save the image
 

# ##Display
# cv.imshow('Card image', im)
# cv.waitKey() # This is necessary to be required so that the image doesn't close immediately.  
# #It will run continuously until the key press.  
# cv.destroyAllWindows() 