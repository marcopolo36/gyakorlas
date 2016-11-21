/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package lift;

/**
 *
 * @author Divényi Márk
 */
public class LiftApp {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        Lift l = new Lift(10);
        l.zar();
        try {
            l.emeletValasztas(0); // Ne történjen semmi
            l.emeletValasztas(5); // A lift írja ki 0-5. emeletig és az írányt is
            l.nyit();
            l.emeletValasztas(2); // Nem történik semmi, mert nyitva van a lift
            l.zar();
            l.emeletValasztas(2); // A lift írja ki 5-2. emeletig és az írányt is
            l.emeletValasztas(-1); // Hibát dob
        } catch(Error e) {
            System.out.println(e.getMessage());
        }
    }
}
