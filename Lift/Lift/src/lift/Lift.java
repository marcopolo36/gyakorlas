package lift;

/*******************************************************************************
 * 2016, All rights reserved.
 *******************************************************************************/

// Start of user code (user defined imports)

// End of user code

/**
 * Description of Lift.
 * 
 * @author Divényi Márk
 */
public class Lift {   
    
        /**
	 * Description of the property emeletAktualis.
	 */
	private int emeletAktualis;

	/**
	 * Description of the property nyitottE.
	 */
	private boolean nyitottE;

	/**
	 * Description of the property maxEmelet.
	 */
	private int maxEmelet;

	/**
	 * The constructor.
         * @param maxEmelet
	 */
	public Lift(int maxEmelet) {
		// Start of user code constructor for Lift)
		this.maxEmelet=maxEmelet;
                this.emeletAktualis=0;
                this.nyitottE=true;
		// End of user code
	}

	/**
	 * Description of the method nyit.
	 */
	public void nyit() {
            this.nyitottE=true;
	}

	/**
	 * Description of the method zar.
	 */
	public void zar() {
            this.nyitottE=false;
	}

	/**
	 * Description of the method emeletValasztas.
	 * @param emelet 
	 */
	public void emeletValasztas(int kivantEmelet) {
            int irany;
            if ( kivantEmelet < 0 || kivantEmelet > maxEmelet) {
                throw new Error("Hibás érték: Nincs ilyen emelet! "
                        + "Pozitív egész számot adjon meg (0 és a " 
                        + maxEmelet + " között).");
            }
            
            if ( nyitottE==false ){
                irany=0;
                if ( kivantEmelet > emeletAktualis ){
                    irany=+1;
                }

                if ( kivantEmelet < emeletAktualis ){
                    irany=-1;
                }
                
                if(irany !=0 ){
                    // minden körben utazunk egy emeletet
                    while( emeletAktualis != kivantEmelet ) {
                        emeletAktualis = emeletAktualis + irany;
                        System.out.print(emeletAktualis);
                        if(irany == -1){
                            System.out.print(" ▼\n");
                        }
                        if(irany == +1){
                            System.out.print(" ▲\n");
                        } 
                    }
                }
            }
	}
}
