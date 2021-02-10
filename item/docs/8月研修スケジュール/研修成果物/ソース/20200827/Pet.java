package Text0411;

public abstract class Pet {
    private String name;
    private int helth;
    private int love;


    public Pet(){

    }

    public Pet(String name, int helth, int love){
        setHelth(helth);
        setLove(love);
        setName(name);
    }






    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getHelth() {
        return helth;
    }

    public void setHelth(int helth) {
        this.helth = helth;
    }

    public int getLove() {
        return love;
    }

    public void setLove(int love) {
        this.love = love;
    }




    public void show(){
        System.out.println("："+getName());
        System.out.println("："+getHelth());
        System.out.println("："+getLove());
    }
}
