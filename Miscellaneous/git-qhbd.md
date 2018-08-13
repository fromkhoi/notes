# Delete local branch. 
git branch -d *branch-name* // Không được nếu chưa đồng bộ với remove.
git branch -D *branch-name* // Xoá con mẹ nó luôn, kệ mẹ nó có đồng bộ ko. OK!

Có thể tiến hành xóa đồng thời nhiều branch bằng cách liệt kê tên các branch cần xóa liền nối tiếp nhau và cách nhau một khoảng trắng

# Delete the most recent commit, keeping the work you've done.
git reset --soft HEAD~1  

# Delete the most recent commit, destroying the work you've done.
git reset --hard HEAD~1

# Push local branch
git push *remote-name* *branch-name* // push một local branch lên remote server thì tên branch mặc định của remote branch lúc này sẽ là tên của local branch.
git push *remote-name* *branch-name*:*name-remote-branch* // push local branch lên remote server với một tên khác.

# Revert-reset commit
git revert *commit-hash-code* // tạo ra một commit mới đảo ngược lại những thay đổi trong commit được chỉ định
git reset --hard *commit-hash-code* // xóa toàn bộ các commit trước đó và đưa branch hiện tại trở về trạng thái của commit-hash-code đã chọn

# Stash
git stash save *comment-note* // lưu stash
git stash list // Xem lại các stash
git stash apply stash@{*id-tash*} // lấy lại thay đổi đã stash
git stash pop stash@{*id-tash*} // xóa stash từ stack sau khi nó được apply nghĩa là mình đã lấy lại được các thay đổi
git stash show stash@{*id-tash*} // xem chi tiết thay đổi với id tash
git stash show -p // xem toàn bộ thay đổi
git stash branch <name> stash@{*id-tash*} // tạo một branch mới với stash mới nhất và sau đó xóa stash mới nhất khỏi stack (giống như pop)
git stash clear // xoá toàn bộ stash đã lưu
git stash drop stash@{*id-tash*} // xoá stash ra khỏi stack

# Tìm lại một stash hoặc commit đã bị xóa
git fsck --no-reflog | awk '/dangling commit/ {print $3}' | xargs git show > filename.txt

git stash apply [comit or stash sha];
