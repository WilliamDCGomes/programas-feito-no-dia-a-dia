package screens;
import java.awt.Frame;
import java.io.File;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFileChooser;
import javax.swing.UIManager;
import javax.swing.UnsupportedLookAndFeelException;
/**
 *
 * @author willi_bg
 */
public class GetFile {
    public static void main(String args[]){
        String filename = "";
        try {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        } catch (InstantiationException | IllegalAccessException | UnsupportedLookAndFeelException | ClassNotFoundException ex) {
            Logger.getLogger(GetFile.class.getName()).log(Level.SEVERE, null, ex);
        }
        JFileChooser files = new JFileChooser();
        File origin = new File("C:/Users/" + System.getProperty("user.name") + "/Desktop");
        files.setDialogTitle("SELECIONE UMA IMAGEM");
        files.setFileSelectionMode(JFileChooser.FILES_ONLY);
        files.setCurrentDirectory(origin);
        int opc = files.showOpenDialog(new Frame());
        if(opc==JFileChooser.APPROVE_OPTION){
            File file = new File("CAMINHO");
            file= files.getSelectedFile();
            filename = file.getAbsolutePath();
        }
        InsertFile insertFile = new InsertFile();
        insertFile.insertData(filename);
        System.exit(0);
    }
}
