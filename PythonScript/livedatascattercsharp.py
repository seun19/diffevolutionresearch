import matplotlib.pyplot as plt
import matplotlib.animation as animation
from matplotlib import style


style.use('fivethirtyeight')
# Scale settings
the_scale = open('csharpscale.txt' , 'r').read()
sc = float(the_scale)

fig = plt.figure()
plt.axis([-sc,sc,-sc,sc])
plt.xlabel("X Axis")
plt.ylabel("Y Axis")
ax1 = fig.add_subplot(1,1,1)

def animate(i):
    # Scale settings - read scale values from file
    the_scale = open('csharpscale.txt' , 'r').read()
    sc = float(the_scale)

    #the_data = open('data.txt' , 'r').read()
    the_data = open('csharpdata.txt' , 'r').read()
    lines = the_data.split('\n')
    xs = []
    ys = []
    for line in lines:
        if (len(line) > 1):
            x,y = line.split(',')
            xs.append(x)
            ys.append(y)
    ax1.clear()
    ax1.scatter(xs,ys)
    plt.axis([-sc,sc,-sc,sc])
    plt.xlabel("X Axis")
    plt.ylabel("Y Axis")
    
ani = animation.FuncAnimation(fig, animate, interval = 1000)
plt.show()
