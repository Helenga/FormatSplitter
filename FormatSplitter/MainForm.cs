using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FormatSplitterCore;


namespace FormatSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SystemDirectoriesTree systemDirectoriesTree = new SystemDirectoriesTree();
        private TreeRootHandler treeRootHandler = new TreeRootHandler();
        private OriginatedDirectoriesTree originatedDirectoriesTree = new OriginatedDirectoriesTree();

        private void button_GetHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Owner = this;
            helpForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var root = treeRootHandler.GetRoot();
            updateLabelPath();
            TreeNode treeNode = new TreeNode() { Text=root };
            treeNode.Expand();
            TreeNode node = new TreeNode();
            var branch = systemDirectoriesTree.TraverseTree(treeNode.Text);
            var extensions = originatedDirectoriesTree.FormTree(root);
            addNodes(treeNode, branch);
            addNodes(node, extensions);
            treeView_SystemTree.Nodes.Add(treeNode);
            treeView_FormedTree.Nodes.Add(node);
            treeView_FormedTree.ExpandAll();
        }

        private void treeView_SystemTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = treeView_SystemTree.SelectedNode;
            TreeNode node = new TreeNode();
            var branch = systemDirectoriesTree.TraverseTree(selectedNode.Text);
            var extensions = originatedDirectoriesTree.FormTree(selectedNode.Text);
            treeView_FormedTree.Nodes.Clear();
            addNodes(selectedNode, branch);
            addNodes(node, extensions);
            selectedNode.Expand();
            treeView_FormedTree.Nodes.Add(node);
            treeView_FormedTree.ExpandAll();
            treeRootHandler.SpecifiedRoot = selectedNode.Text;
            updateLabelPath();
        }

        private void treeView_FormedTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var selectedNode = treeView_FormedTree.SelectedNode.Text;
            FilesForm filesForm = new FilesForm(selectedNode);
            filesForm.Owner = this;
            filesForm.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateLabelPath()
        {
            var root = treeRootHandler.GetRoot();
            label_path.Text = root;
        }

        private void addNodes(TreeNode treeNode, IEnumerable<string> branch)
        {
            foreach (var node in branch)
            {
                TreeNode subTreeNode = new TreeNode() { Text = node };
                treeNode.Nodes.Add(subTreeNode);
            }
            treeNode.EnsureVisible();
        }
    }
}
