/****************************************************************************
**
** Copyright (C) 2012 Digia Plc and/or its subsidiary(-ies).
** Contact: http://www.qt-project.org/legal
**
** This file is part of the Qt VS Add-in.
**
** $QT_BEGIN_LICENSE:LGPL$
** Commercial License Usage
** Licensees holding valid commercial Qt licenses may use this file in
** accordance with the commercial license agreement provided with the
** Software or, alternatively, in accordance with the terms contained in
** a written agreement between you and Digia.  For licensing terms and
** conditions see http://qt.digia.com/licensing.  For further information
** use the contact form at http://qt.digia.com/contact-us.
**
** GNU Lesser General Public License Usage
** Alternatively, this file may be used under the terms of the GNU Lesser
** General Public License version 2.1 as published by the Free Software
** Foundation and appearing in the file LICENSE.LGPL included in the
** packaging of this file.  Please review the following information to
** ensure the GNU Lesser General Public License version 2.1 requirements
** will be met: http://www.gnu.org/licenses/old-licenses/lgpl-2.1.html.
**
** In addition, as a special exception, Digia gives you certain additional
** rights.  These rights are described in the Digia Qt LGPL Exception
** version 1.1, included in the file LGPL_EXCEPTION.txt in this package.
**
** GNU General Public License Usage
** Alternatively, this file may be used under the terms of the GNU
** General Public License version 3.0 as published by the Free Software
** Foundation and appearing in the file LICENSE.GPL included in the
** packaging of this file.  Please review the following information to
** ensure the GNU General Public License version 3.0 requirements will be
** met: http://www.gnu.org/copyleft/gpl.html.
**
**
** $QT_END_LICENSE$
**
****************************************************************************/

#ifndef RESOURCEVIEW_H
#define RESOURCEVIEW_H

#include "resourcefile_p.h"

#include <QtWidgets/QTreeView>
#include <QtCore/QPoint>

using namespace qdesigner_internal;

QT_BEGIN_NAMESPACE
class QAction;
class QMenu;
class QMouseEvent;
class QUndoStack;
QT_END_NAMESPACE

namespace SharedTools {

/*!
    \class EntryBackup

    Holds the backup of a tree node including children.
*/
class EntryBackup
{
protected:
    ResourceModel *m_model;
    int m_prefixIndex;
    QString m_name;

    EntryBackup(ResourceModel &model, int prefixIndex, const QString &name)
            : m_model(&model), m_prefixIndex(prefixIndex), m_name(name) { }

public:
    virtual void restore() const = 0;
    virtual ~EntryBackup() { }
};

namespace Internal {
    class RelativeResourceModel;
}

class ResourceView : public QTreeView
{
    Q_OBJECT

public:
    enum NodeProperty {
        AliasProperty,
        PrefixProperty,
        LanguageProperty
    };

    ResourceView(QUndoStack *history, QWidget *parent = 0);
    ~ResourceView();

    bool load(const QString &fileName);
    bool save();
    QString fileName() const;
    void setFileName(const QString &fileName);

    bool isDirty() const;
    void setDirty(bool dirty);

    void enableContextMenu(bool enable);

    void addFiles(QStringList fileList, const QModelIndex &index);

    void addFile(const QString &prefix, const QString &file);
//    void removeFile(const QString &prefix, const QString &file);

    bool isPrefix(const QModelIndex &index) const;

    QString currentAlias() const;
    QString currentPrefix() const;
    QString currentLanguage() const;

    void setResourceDragEnabled(bool e);
    bool resourceDragEnabled() const;

    void setDefaultAddFileEnabled(bool enable);
    bool defaultAddFileEnabled() const;

    void findSamePlacePostDeletionModelIndex(int &row, QModelIndex &parent) const;
    EntryBackup *removeEntry(const QModelIndex &index);
    void addFiles(int prefixIndex, const QStringList &fileNames, int cursorFile,
                  int &firstFile, int &lastFile);
    void removeFiles(int prefixIndex, int firstFileIndex, int lastFileIndex);
    QStringList fileNamesToAdd();
    QModelIndex addPrefix();

public slots:
    void onAddFiles();
    void setCurrentAlias(const QString &before, const QString &after);
    void setCurrentPrefix(const QString &before, const QString &after);
    void setCurrentLanguage(const QString &before, const QString &after);
    void advanceMergeId();

protected:
    void setupMenu();
    void changePrefix(const QModelIndex &index);
    void changeLang(const QModelIndex &index);
    void changeAlias(const QModelIndex &index);
    void mouseReleaseEvent(QMouseEvent *e);
    void keyPressEvent(QKeyEvent *e);

signals:
    void removeItem();
    void dirtyChanged(bool b);
    void currentIndexChanged();

    void addFilesTriggered(const QString &prefix);
    void addPrefixTriggered();

protected slots:
    void currentChanged(const QModelIndex &current, const QModelIndex &previous);

private slots:
    void onEditAlias();
    void onEditPrefix();
    void onEditLang();
    void popupMenu(const QModelIndex &index);

public:
    QString getCurrentValue(NodeProperty property) const;
    void changeValue(const QModelIndex &nodeIndex, NodeProperty property, const QString &value);

private:
    void addUndoCommand(const QModelIndex &nodeIndex, NodeProperty property,
                        const QString &before, const QString &after);

    QPoint m_releasePos;

    qdesigner_internal::ResourceFile m_qrcFile;
    Internal::RelativeResourceModel *m_qrcModel;

    QAction *m_addFile;
    QAction *m_editAlias;
    QAction *m_removeItem;
    QAction *m_addPrefix;
    QAction *m_editPrefix;
    QAction *m_editLang;
    QMenu *m_viewMenu;
    bool m_defaultAddFile;
    QUndoStack *m_history;
    int m_mergeId;
};

} // namespace SharedTools

#endif // RESOURCEVIEW_H
